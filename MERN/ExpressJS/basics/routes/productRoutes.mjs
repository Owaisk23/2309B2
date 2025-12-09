import productController from "../controller/productController.mjs";
import express from 'express';
import userController from "../controller/userController.mjs";
import { upload } from "../cloudinaryConfig.mjs";

const productRouter = express.Router();

//fetch all products
productRouter
.get('/', userController.auth, productController.index)
.get('/:id', productController.singleProduct)
// .post('/', productController.create)
// .post('/add', upload.single('image'), productController.addProductWithImage)
.post('/add', userController.auth, upload.array('image'), productController.addProductWithImage)
// .post('/', productController.addProduct)
.delete('/:id', productController.deleteProduct)
.put('/:id', productController.editProduct);

export default productRouter;