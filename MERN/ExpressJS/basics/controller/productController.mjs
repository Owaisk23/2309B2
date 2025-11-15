// import fs from 'node:fs';
import Product from "../models/productModel.mjs";

// Fetching data from database
let index = async (req, res) => {
  try {
    const products = await Product.find();
    if(products.length > 0){
      res.status(200).json({ message: "Products found", products: products });
    } else {
      res.status(404).json({ message: "No products found" });
    }
  } catch (error) {
    console.log(error);
    res.status(500).json({ message: error.message })
  }
}


// fetch data by id
let singleProduct = async (req, res) => {
  try {
    let id = req.params.id;
    const product = await Product.findById(id);
    if (product) {
      res.status(200).json({ message: "Product found", products: product });
    } else {
      res.status(404).json({ message: "No product found" });
    }
  } catch (error) {
    console.log(error);
    res.status(500).json({ message: error.message })
  }
}


let create = async (req, res) => {
  try {
    const {
      title,
      description,
      price,
      discountedPercentage,
      rating,
      stock,
      brand,
      category,
      thumbnail,
      images
    } = req.body;


    const product = new Product({
      title,
      description,
      price,
      discountedPercentage,
      rating,
      stock,
      brand,
      category,
      thumbnail,
      images
    });

    // mongoose method to save data to database
    const addProd = await product.save();
    // mongodb method to save data to database
    // let addProd = await Product.insertOne(product);

    res.status(201).json({
      message: "Product created successfully",
      product: addProd
    });

  } catch (error) {
    console.log(error);

    if (error.name === "ValidationError") {
      return res.status(400).json({ message: error.message });
    }

    res.status(500).json({ message: error.message });
  }
};

let deleteProduct = async (req, res) => {
  try {
    let id = req.params.id;
    const deletedProduct = await Product.findByIdAndDelete(id);
    if (deletedProduct) {
      res.status(200).json({ message: "Product deleted successfully", product: deletedProduct });
    } else {
      res.status(404).json({ message: "No product found to delete" });
    }
  } catch (error) {
    console.log(error);
    res.status(500).json({ message: error.message })
  }
}

let editProduct = async (req, res) => {
  try {
    let id = req.params.id;
    const updatedProduct = await Product.findByIdAndUpdate(id, req.body, { new: true, runValidators: true });
    if (updatedProduct) {
      res.status(200).json({ message: "Product updated successfully", product: updatedProduct });
    } else {
      res.status(404).json({ message: "No product found to update" });
    }
  } catch (error) {
    console.log(error);
    res.status(500).json({ message: error.message })
  }
}

// let addProductWithImage = async (req, res) => {
//   try {
//     console.log(req.file)
//     console.log(req.file.path);
//     let newProduct = new Product({
//       title: req.body.title,
//       description: req.body.description,
//       price: req.body.price,
//       discountedPercentage: req.body.discountPercentage,
//       rating: req.body.rating,
//       stock: req.body.stock,
//       brand: req.body.brand,
//       category: req.body.category,
//       thumbnail: req.file.path,
//       images: req.file.path

//     });

//     let addprod = await Product.insertOne(newProduct);
//     if (!addprod) {
//       res.status(404).json({ message: "Failed to add product" });
//     } else {

//       res.status(200).json({
//         message: "Product added successfully",
//         product: addprod,
//       })
//     }
//   } catch (error) {
//     console.log(error);
//     res.status(500).json({ message: "Internal server errror" });
//   }
// }


// image
 let addProductWithImage=async(req,res)=>{
try {
console.log(req.files)
let imagesArray = []
req.files.forEach(element => {
  console.log( "element",element.path)
  imagesArray.push(element.path);
});
console.log(imagesArray)

// console.log(req.file.path);
let newProduct = new Product({
     title:req.body.title,
        description:req.body.description,
        price:req.body.price,
        discountPercentage:req.body.discountPercentage,
        rating:req.body.rating,
        stock:req.body.stock,
        brand:req.body.brand,
        category:req.body.category,
        thumbnail:imagesArray[0],
        images:imagesArray

});

let addprod = await Product.insertOne(newProduct);
if (!addprod) {
       res.status(404).json({message:"Failed to add product"});
} else {

    res.status(200).json({
    message:"Product added successfully",
    product:addprod,
})
} 



} catch (error) {
   console.log(error) ;
   res.status(500).json({message:"Internal server errror"});
}
}
// const data = JSON.parse(fs.readFileSync('data.json', 'utf-8'));

// let products = data.products;

// let index = (req, res) => {
//   try{
//     res.status(200).json({message: "Products fetched successfully", products: products})
//   }
//   catch(err){
//     res.status(500).json({message: "Error fetching products", error: err.message})
//   }
// }

// let singleProduct = (req, res) => {
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
// }

// let addProduct = (req, res) => {
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
// }

// let deleteProduct = (req, res) => {
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
// }

const productController = {
    index,
    singleProduct,
    create,
    // addProduct,
    editProduct,
    deleteProduct,
    addProductWithImage
}

export default productController;