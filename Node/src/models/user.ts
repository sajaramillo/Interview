import mongoose from "mongoose";

const UserSchema = new mongoose.Schema({
    userName:{
        type: String,
        require: true
    },
    password:{
        type: String,
        require: true
    }
})

const User = mongoose.model('User', UserSchema);

export {User}