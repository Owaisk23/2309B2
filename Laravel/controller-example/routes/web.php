<?php

use Illuminate\Support\Facades\Route;
use \App\Http\Controllers\AppController;

//HomePage Route
// Route::get('/', function () {
//     return view('welcome');
// });

// //service route
// Route::get('/service', function () {
//     return view('service');
// });

// //about route
// Route::get('/about/{paramname?}', function () {
//     return view('about');
// });

Route::get('/', [AppController::class, 'index']);

Route::get('/about', [AppController::class, 'about']);