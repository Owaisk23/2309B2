<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class AppController extends Controller
{
    //
    public function index(){
        // return "Hello From AppController";

        $username = "Owais";
        $userage = 23;
        // // Compact Method
        // return view("welcome", compact("username", "userage"));

        // using associative array
        // return view("welcome", array(
        //     'username' => $username,
        //     'userage' => $userage
        // ));

        // using with method
        return view("welcome")->with('username', value: $username)->with('userage', value: $userage);


    }

    public function about(){
        return view("about");
    }
}
