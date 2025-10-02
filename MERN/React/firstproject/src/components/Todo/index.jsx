import React from "react";
import { useState } from "react";

const Todo = () => {
  const [list, setList] = useState(["Pak", "Bharat", "Dubai"]);
  const [text, setText] = useState("");

  const addTodo = () => {
    if (text === "") {
      alert("Please enter a valid todo");
      return;
    }
    setList([...list, text]);
    setText("");
  };
  return (
    <>
      <h1>Todo Application</h1>
      <input type="text" value={text} onChange={(e) => setText(e.target.value)} />
      <button className="btn btn-primary" onClick={addTodo}>
        Add Todo
      </button>

      <h2>Todo List:</h2>
      {list.length > 0 ? (
        list.map((item, index) => {
          return (
            <div key={index} className="d-flex align-items-center gap-3 mb-2">
              <h3 >
                {index + 1}. {item}
              </h3>
              <button className="btn btn-success" >Edit</button>
              <button className="btn btn-danger" >Delete</button>
            </div>
          );
        })
      ) : (
        <h3>No Item Found</h3>
      )}
    </>
  );
};

export default Todo;
