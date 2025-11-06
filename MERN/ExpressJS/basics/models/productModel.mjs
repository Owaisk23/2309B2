import mongoose from 'mongoose';
const { Schema } = mongoose;

const productSchema = new Schema({
  title: {type: String, required: [true, "Title is required"]}, // String is shorthand for {type: String}
  description: {type: String},
  price: {type: Number, required: [true, "Price is required"]},
  discountedPercentage: {
    type: Number,
    required: [true, "Discount is required"],
    min: [0, "Discount Percentage can't be less than zero"],
    max: [50, "Discount Percentage can't be greater than 50"],
  },
  rating: {
    type: Number,
    min: [0, "Rating can't be less than zero"],
    max: [5, "Rating can't be greater than 5"],
    default: 0,
  },
  stock: {
    type: Number,
    min: [0, "Stock can't be less than zero"],},
  brand: {type: String, required: [true, "Brand is required"]},
  category: {type: String, required: [true, "Category is required"]},
  thumbnail: {type: String, required: [true, "Thumbnail is required"]}, 
  images: {type: String, required: [true, "Images is required"]},
});

const Product = mongoose.model('Product', productSchema);

export default Product;