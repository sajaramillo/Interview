import express, { Request, Response } from "express";
import { User } from "../models/user";



const router = express.Router();
router.get('/api/users/hello',
    async (req: Request, res: Response) => {
        
        res.status(200).send( "Bienvenido al reto NodeJs" );
    });

export { router as helloRouter };