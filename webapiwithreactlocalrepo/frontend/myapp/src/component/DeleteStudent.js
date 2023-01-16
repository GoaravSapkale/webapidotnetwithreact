import { useState } from "react";

import axios from "axios";

const DeleteStudent=()=>{
    const [apiData,setapiData]=useState({id:""});

    const deletestd=(event)=>
    {
        event.preventDefault();
        axios.delete(`http://localhost:5021/api/student/${apiData.id}`);

    }

    const handleChange=(event)=>
    {
        const {name,value}=event.target
        setapiData({...apiData,[name]:value});
    }




    return(
        <>
        <h2>Enter Student roll to Delete</h2>
        <form method="GET" onSubmit={deletestd}>
            <input type="text" name="id" onChange={handleChange} placeholder="studentid"></input>
            <input type="Submit" value="Delete"></input>
        </form>
        </>
    );
}

export default DeleteStudent;