import productController from "../controller/productController.mjs";
import express from 'express';

const productRouter = express.Router();

//fetch all products
productRouter
.get('/', productController.index)
.get('/:id', productController.singleProduct)
.post('/', productController.addProduct)
.delete('/:id', productController.deleteProduct);

export default productRouter;