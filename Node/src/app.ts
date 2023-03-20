import express from 'express';
import mongoose from "mongoose";

import { signupRouter } from './routes/signup';
import { helloRouter } from './routes/hello';
const app = express();
app.use(express.json());
//add routes
app.use(signupRouter);
app.use(helloRouter);
const port = 3000;

const start = async () => {
    try {
        await mongoose.connect('mongodb://127.0.0.1:27017/InterviewAuth');        
        
    }
    catch (err) {
        console.log(err);
    }    
    //initialize app server
    app.listen(port, () => {        
      return console.log(`Express is listening at http://localhost:${port}`);
    });
}

start();



