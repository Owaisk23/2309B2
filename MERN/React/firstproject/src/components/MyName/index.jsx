import React from "react";
// import "./index.css"; 
import styles from "./index.module.css";

const MyName = (props) => {
  return (
    <>
      <h1 className={`${styles.heading} bg-warning `}>My name is {props.name}.</h1>
      <h2>My profession is {props.profession}.</h2>
    </>
  );
};

export default MyName; 