import express, { Request, Response } from "express";
import { User } from "../models/user";



const router = express.Router();
router.post('/api/users/signup',
    async (req: Request, res: Response) => {
        const { email, password } = req.body;
        //create a new user
        const user = new User({
            userName: email,
            password: password
        });
        //save the new user
        await user.save();        
        //return serve response
        res.status(201).send({ user });
    });

export { router as signupRouter };