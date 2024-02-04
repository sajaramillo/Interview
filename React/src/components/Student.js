import {React} from "react";
import { useState ,useEffect } from "react";
import axios from "axios";
import StudentModal from "./StudentModal";


const Student = ()=>{
    const [studentList, setStudentList] = useState([]);
    const [modalState, setModalState] = useState(false);
    const [studentModal, setStudentModal] = useState("")
    
    useEffect(()=>{
        axios.get(`https://65bab8cdb4d53c0665538761.mockapi.io/api/v1/students`)
        .then(response => setStudentList(response.data))
    }, []);


    const assignStatus = (score) => {
        if (score >= 7) return 'Aprobado';
        if (score >= 5.5) return 'Suspenso';
        if (score < 5.5) return 'Reprobado';
      };

    function getClassNameByStatus(score){
        if (score >= 7) return 'table-success';
        if (score < 5.5) return 'table-danger';
        if (score >= 5.5) return 'table-warning';           
        
    };

    const handleClickModal = (student) => {
        setStudentModal(student);
        setModalState(true);
      };
    
      const handleCloseModal = () => {
        setModalState(false);
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
                            <tr key={index} className="table-light">
                                <td>{index + 1}</td>
                                <td>{student.name}</td>
                                <td className={getClassNameByStatus(student.score)}>{assignStatus(student.score)}</td>        
                                <td><button className="details-button" onClick={() => handleClickModal(student)}>See details</button></td>                        
                            </tr>                        
                    )}
                </tbody>
            </table>
            {modalState && <StudentModal student={studentModal} onClose={handleCloseModal} />}

        </div>
    );
};

export default Student;