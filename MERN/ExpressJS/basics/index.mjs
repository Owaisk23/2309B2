// const express = require('express')
import express from 'express';
// import path from 'path';
// import fs from 'node:fs';
import productRouter from './routes/productRoutes.mjs';
// getting-started.js
// const mongoose = require('mongoose');
import mongoose from 'mongoose';
import userRouter from './routes/userRoutes.mjs';
const app = express()
const port = 3000
// const dirname = path.resolve();

app.use(express.json());


main().catch(err => console.log(err));

async function main() {
  await mongoose.connect('mongodb+srv://owaisahmedkhan:owais123@cluster0.mbgw7ps.mongodb.net/Mart');
  console.log("MongoDB Connected!")
  // use `await mongoose.connect('mongodb://user:password@127.0.0.1:27017/test');` if your database has auth enabled
}

// const data = JSON.parse(fs.readFileSync('data.json', 'utf-8'));

// let products = data.products;

// app.get('/', (req, res) => {
//   res.send('Hello World!')
// })

// // app.get('/contact', (req, res) => {
// //   res.send('Hello from Contact Page!')
// // })

// app.get('/image', (req, res) => {
//   res.sendFile(dirname + '/static/Citiguide.PNG')
// })

// app.use('/home', express.static(dirname, {index: '/static/index.html'}));

// // Router Parameter (They are compulsory)
// // app.get('/product/:id', (req, res) => {
// //   res.json({name: "Product No " + req.params.id})
// // })

// app.get('/posts/:id', (req, res) => {
//   let postId = req.params.id;
//   let postObj = [
//     {
//     id: 1,
//     title: "Exploring Node.js",
//     content: "Learn how to build scalable backend applications using Node.js.",
//     author: "Owais Ahmed",
//     date: "2025-10-18"
//   },
//   {
//     id: 2,
//     title: "Frontend Tips",
//     content: "Best practices for creating responsive designs with CSS Grid and Flexbox.",
//     author: "Ammad Khan",
//     date: "2025-10-17"
//   },
//   {
//     id: 3,
//     title: "MongoDB Aggregation",
//     content: "A deep dive into MongoDB aggregation pipelines for data analysis.",
//     author: "Ali Raza",
//     date: "2025-10-16"
//   },
//   {
//     id: 4,
//     title: "API Security Basics",
//     content: "Learn about authentication, authorization, and securing REST APIs.",
//     author: "Zain Ahmed",
//     date: "2025-10-15"
//   }
//   ]

//   postObj.map((post) => {
//     if(post.postId == postId){
//       console.log(post);
//       postObj =post
//     }
//   })

//   res.send(postObj);
//   // res.json({name: "Product No " + req.params.id})
// })

// //Query Paramater (They are optional)
// app.get('/categories', (req, res) => {
//   if(req.query.name){
//     res.json({name: "Category " + req.query.name})
//   }
//   else{
//     res.json({name: "All Categories "})
//   }
// })

// // Req Body (They are used to send data to server)

// app.post('/contact', (req, res) => {
//   // const name = req.body.name;
//   // const email = req.body.email;
//   // const message = req.body.message;

//   // destructing
//   const {name, email, message} = req.body;

//   res.json({name: name, email: email, message: message})
// })

//fetch all products
// app.get('/products', (req, res) => {
//   try{
//     res.status(200).json({message: "Products fetched successfully", products: products})
//   }
//   catch(err){
//     res.status(500).json({message: "Error fetching products", error: err.message})
//   }
// })

//fetch single product

// app.get('/product/:id', (req, res) => {
//   try{
//     let productId = req.params.id;
//     let product = products.find(p => p.id == productId);
//     if(product){
//           res.status(200).json({message: "Products fetched successfully", products: product})
//     }else{
//           res.status(404).json({message: "Product not found"})
//     }
//   }
//   catch(err){
//     res.status(500).json({message: "Error fetching products", error: err.message})
//   }
// })

// add product
// app.post('/addproduct', (req, res) => {
//   try{
//     let newProduct =req.body;
//     let addproduct = products.push(newProduct);
//     console.log(newProduct);
//     if(addproduct){
//           res.status(200).json({message: "Products added successfully", products: newProduct})
//     }else{
//           res.status(404).json({message: "Product not added"})
//     }
//   }
//   catch(err){
//     res.status(500).json({message: "Error fetching products", error: err.message})
//   }
// })

// Delete product
// app.delete('/deleteproduct/:id', (req, res) => {
//   try{
//     let productId = req.params.id;
//     let deleteProduct = products.find(p => p.id == productId);
//     if(!deleteProduct){
//       return res.status(404).json({message: "Product not found"})
//     }
//     products = products.filter(p => p.id != productId);
//     res.status(200).json({message: "Product deleted successfully", products: products})
//   }
//   catch(err){
//     res.status(500).json({message: "Error deleting products", error: err.message})
//   }
// })

app.use('/products', productRouter);
app.use('/users', userRouter);

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})
