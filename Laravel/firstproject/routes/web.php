<?php

use Illuminate\Support\Facades\Route;


// Base route
Route::get('/', function () {
    return view('welcome');
});

//About Page Route
Route::get('/about', function () {
    return view('about');
});

//Faqs Page Route with another way
Route::view('/faqs', 'faqs');

// Routes with required parameters
// Route::get('/products/{paramname}', function () {
//     return view('products');
// });

// Routes with optional parameters
Route::get('/products/{paramname?}', function () {
    return view('products');
});
