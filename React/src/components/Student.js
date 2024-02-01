import {React, useEffect, useState} from "react";
import StudentModal from "../studentModal";
import axios from 'axios';

const Student =()=>{
  const [studentList, setStudentList] = useState([]);

  useEffect(()=>{
    axios.get('https://65bb1241b4d53c066553f4ea.mockapi.io/api/v1/users')
    .then(response=>setStudentList(response.data)) 

  },
  []);



    function getClassNameByStatus(score){
      let status;
        switch(true){
            case score >=7: status ='Aprobado';
            break;
            case score >=5.5 && score <7: status = 'Suspenso';
            break;
            default: status = 'Reprobado';
        }
        return status;
    }
    function getStatusColor(status){
      switch(status){
        case 'Aprobado':
          return {backgroundColor:'#C2F9C0'};
        case 'Suspenso':
          return {backgroundColor: '#FCFC8F'};
        case 'Reprobado':
          return {backgroundColor: '#F08080'};
        default:
          return;
      }
    }
    const [selectedStudent, setSelectedStudent] = useState(null);

    const openModal = (student) => {
        setSelectedStudent(student);
    };

    const closeModal = () => {
        setSelectedStudent(null);
    };

    return(
        <div>
            <h2>Lista de estudiantes</h2>
            <table className="table table-sm">
                <thead>
                    <th>#</th>
                    <th>Nombre</th>
                    <th>Estado</th>
                </thead>
                <tbody>
                    {
                        studentList.map((student, index) =>                        
                            <tr className="table-light">
                                <td>{index +1}</td>
                                <td>{student.name}</td>
                                <td style={getStatusColor(getClassNameByStatus(student.score))}>
                                    {getClassNameByStatus(student.score)}  
                                </td> 
                                <td>
                                  <button style={{backgroundColor: '#007BFF', 
                                        color: '#FFFFFF', 
                                        border: 'none', 
                                        borderRadius: '5px'}} onClick={() => openModal(student)}>See Details</button>
                                </td>                               
                            </tr>                        
                    )}
                </tbody>
            </table>
            {selectedStudent && (
                <StudentModal student={selectedStudent} closeModal={closeModal} status={getClassNameByStatus(selectedStudent.score)}/>
            )}
        </div>
    );
};

export default Student;