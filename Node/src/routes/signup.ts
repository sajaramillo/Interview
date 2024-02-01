import express, { Request, Response } from "express";
import { validationResult, check } from "express-validator";
import bcrypt from "bcrypt";
import { User } from "../models/user";

const router = express.Router();

//  validacion  el email y la contraseña
const validateSignup = [
  check("email")
    .isEmail()
    .withMessage("El correo electrónico debe ser un email válido"),
  check("password")
    .isLength({ min: 4, max: 20 })
    .withMessage("La clave debe tener entre 4 y 20 caracteres")
    .matches(/[A-Z]/)
    .withMessage("La clave debe contener al menos una letra mayúscula")
    .matches(/\d/)
    .withMessage("La clave debe contener al menos un número"),
];

router.post(
  "/api/users/signup",
  validateSignup,
  async (req: Request, res: Response) => {
    // Chequa las validacion de errors
    const errors = validationResult(req);
    if (!errors.isEmpty()) {
      return res.status(400).json({
        statusCode: 400,
        error: errors.array(),
      });
    }

    const { email, password } = req.body;

    // Hashing de la contraseña
    const hashedPassword = await bcrypt.hash(password, 10);

    // Crear un nuevo usuario con la contraseña hasheada
    const user = new User({
      userName: email,
      password: hashedPassword,
    });

    try {
      // Guardar el nuevo usuario en la base de datos
      await user.save();
      // Enviar respuesta de éxito
      res.status(201).send({ user });
    } catch (error) {
      // Manejar errores de base de datos
      res
        .status(500)
        .send({ error: "Error al registrar al usuario en la base de datos" });
    }
  }
);

export { router as signupRouter };
