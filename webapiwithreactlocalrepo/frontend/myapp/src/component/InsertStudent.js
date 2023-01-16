import { useState } from "react";
import axios from "axios";

const InsertStudent=()=>{
    const [apiData,setapiData]=useState({name:"",course:""});

    const inserdata = (event)=>
    {
        event.preventDefault();
        axios.post('http://localhost:5021/api/student',apiData);

    }

    const handleChange=(event)=>
    {
        const {name,value}=event.target
        setapiData({...apiData,[name]:value})
    }

    return(
        <>
        <h1>Add new Student</h1>
        <form method="POST" onSubmit={inserdata}>
            <input type="text" name="name" onChange={handleChange} placeholder="studentname"></input>
            <input type="text" name="course" onChange={handleChange} placeholder="course"></input>
            <input type="submit"></input>
        </form>
        </>
    );
}

export default InsertStudent;