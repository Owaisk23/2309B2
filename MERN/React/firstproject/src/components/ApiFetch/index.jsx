import React from "react";
import { useEffect } from "react";
import { useState } from "react";

const ApiFetch = () => {
  // UseState Hook Start
  const [count, setCount] = useState(0);

  // UseEffect Hook
    useEffect(() => {
        console.log("UseEffect Called");
        getProducts();
    }, []);
  //functions
  const getProducts = async () => {
    try{
        const response = await fetch("https://dummyjson.com/products");
        const data = await response.json();
        console.log("Products Data:", data);
    }
    catch(error){
        console.log("Error fetching products:", error);
    }
  }

  return (
    <>
      <h1>Use Effect</h1>
      <button className="btn btn-primary" onClick={() => setCount(count + 1)}>
        Increment({count})
      </button>
    </>
  );
};

export default ApiFetch;
