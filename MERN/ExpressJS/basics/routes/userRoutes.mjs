import userController from '../controller/userController.mjs';
import express from 'express';


const userRouter = express.Router();

//fetch all products
userRouter
.get('/', userController.index)
.post('/signup', userController.Signup)

export default userRouter;