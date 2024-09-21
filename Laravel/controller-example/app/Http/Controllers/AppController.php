<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class AppController extends Controller
{
    //
    public function index(){
        return "Hello From AppController";
    }

    public function about(){
        return view("about");
    }
}
