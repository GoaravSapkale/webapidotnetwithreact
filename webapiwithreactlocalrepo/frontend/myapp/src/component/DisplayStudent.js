

import {useEffect,useState} from "react";
import axios from 'axios';


const DisplayStudent=()=>{

    const [apiData,setapiData]=useState([]);

    useEffect(
        ()=>
        {
            axios.get('http://localhost:5021/api/student')
            .then(response=>{setapiData(response.data)});
        }
    )

    var renderList=apiData.map(obj=>
        {
            return(
            <tr>
                <td>{obj.id}</td>
                <td>{obj.name}</td>
                <td>{obj.course}</td>
            </tr>
            );
        }
    
        );

    return(
        <>
        <table border="2" bgcolor="pink" height="200px" width="300px">
            <tr>
                <td>Id</td>
                <td>Name</td>
                <td>Course</td>
            </tr>
            {renderList}
        </table>
        </>
    );
}

export default DisplayStudent;