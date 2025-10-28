import fs from 'node:fs';


const data = JSON.parse(fs.readFileSync('data.json', 'utf-8'));

let products = data.products;

let index = (req, res) => {
  try{
    res.status(200).json({message: "Products fetched successfully", products: products})
  }
  catch(err){
    res.status(500).json({message: "Error fetching products", error: err.message})
  }
}

let singleProduct = (req, res) => {
  try{
    let productId = req.params.id;
    let product = products.find(p => p.id == productId);
    if(product){
          res.status(200).json({message: "Products fetched successfully", products: product})
    }else{
          res.status(404).json({message: "Product not found"})
    }
  }
  catch(err){
    res.status(500).json({message: "Error fetching products", error: err.message})
  }
}

let addProduct = (req, res) => {
  try{
    let newProduct =req.body;
    let addproduct = products.push(newProduct);
    console.log(newProduct);
    if(addproduct){
          res.status(200).json({message: "Products added successfully", products: newProduct})
    }else{
          res.status(404).json({message: "Product not added"})
    }
  }
  catch(err){
    res.status(500).json({message: "Error fetching products", error: err.message})
  }
}

let deleteProduct = (req, res) => {
  try{
    let productId = req.params.id;
    let deleteProduct = products.find(p => p.id == productId);
    if(!deleteProduct){
      return res.status(404).json({message: "Product not found"})
    }
    products = products.filter(p => p.id != productId);
    res.status(200).json({message: "Product deleted successfully", products: products})
  }
  catch(err){
    res.status(500).json({message: "Error deleting products", error: err.message})
  }
}

const productController = {
    index,
    singleProduct,
    addProduct,
    deleteProduct
}

export default productController;