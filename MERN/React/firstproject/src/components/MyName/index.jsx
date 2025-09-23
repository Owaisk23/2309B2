import React from "react";

const MyName = (props) => {
  return (
    <>
      <h1>My name is {props.name}.</h1>
      <h2>My profession is {props.profession}.</h2>
    </>
  );
};

export default MyName;