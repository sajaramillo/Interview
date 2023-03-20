"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const mongoose_1 = __importDefault(require("mongoose"));
const signup_1 = require("./routes/signup");
const hello_1 = require("./routes/hello");
const app = (0, express_1.default)();
app.use(express_1.default.json());
//add routes
app.use(signup_1.signupRouter);
app.use(hello_1.helloRouter);
const port = 3000;
const start = () => __awaiter(void 0, void 0, void 0, function* () {
    try {
        yield mongoose_1.default.connect('mongodb://127.0.0.1:27017/InterviewAuth');
    }
    catch (err) {
        console.log(err);
    }
    //initialize app server
    app.listen(port, () => {
        return console.log(`Express is listening at http://localhost:${port}`);
    });
});
start();
//# sourceMappingURL=app.js.map