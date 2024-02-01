import { React, useEffect, useState } from "react";
import { Button, Modal, Box } from "@mui/material";
import axios from "axios";

//Estilo de Modal
const styleModal = {
  position: "center",
  left: "50%",
  top: "50%",
  margin: "10px",
  width: 400,
  height: 250,
  backgroundColor: "white",
  border: "1px solid #000",
  boxShadow: 24,
  p: 4,
};

const Student = () => {
  const studentList = [
    { name: "Juan Santamaría", score: 9.75 },
    { name: "Carlos Ugarte", score: 6.25 },
    { name: "María Armijos", score: 8.5 },
    { name: "José Baquero", score: 5.15 },
    { name: "Carlos Ordoñez", score: 7.75 },
  ];

  const [isOpen, setIsOpen] = useState(false);
  const [selectedStudent, setSelectedStudent] = useState("");
  const handleClickButton = (student) => {
    setSelectedStudent(student);
    setIsOpen(true);
  };

  const [users, setUsers] = useState([]);

  for (let i = 0; i < studentList.length; i++) {
    if (studentList[i].score >= 7) {
      studentList[i].status = "Aprobado";
    }
    if (studentList[i].score < 7 && studentList[i].score >= 5.5) {
      studentList[i].status = "Suspenso";
    }
    if (studentList[i].score < 5.5) {
      studentList[i].status = "Reprobado";
    }
  }

  for (let i = 0; i < users.length; i++) {
    if (users[i].score >= 7) {
      users[i].status = "Aprobado";
    }
    if (users[i].score < 7 && users[i].score >= 5.5) {
      users[i].status = "Suspenso";
    }
    if (users[i].score < 5.5) {
      users[i].status = "Reprobado";
    }
  }

  function getClassNameByStatus(estado) {
    switch (estado) {
      case "Aprobado":
        return "table-success";
      case "Reprobado":
        return "table-danger";
      case "Suspenso":
        return "table-warning";
      default:
        return "primary";
    }
  }
  useEffect(() => {
    const retrieveUsers = async () => {
      const response = await axios.get(
        "https://65b71fde46324d531d53f057.mockapi.io/api/v1/users"
      );
      setUsers(response.data);
    };
    retrieveUsers();
  }, []);

  return (
    <div>
      <h2>Lista de estudiantes</h2>
      <table className="table table-sm">
        <thead>
          <th>#</th>
          <th>Nombre</th>
          <th>Estado</th>
        </thead>
        <tbody>
          {studentList.map((student, index, status) => (
            <tr className="table-light">
              <td>{index + 1}</td>
              <td>{student.name}</td>
              <td className={getClassNameByStatus(student.status)}>
                {student.status}
              </td>
              <td>
                <Button
                  variant={"contained"}
                  onClick={() => handleClickButton(student)}
                >
                  See Details
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>

      <h2>Lista de Estudiantes desde MockAPI</h2>
      <table className="table table-sm">
        <thead>
          <th>#</th>
          <th>Nombre</th>
          <th>Estado</th>
        </thead>
        <tbody>
          {users.map((user, id) => (
            <tr className="table-light">
              <td key={user.id}>{user.id}</td>
              <td>{user.name}</td>
              <td className={getClassNameByStatus(user.status)}>
                {user.status}
              </td>
              <td>
                <Button
                  variant={"contained"}
                  onClick={() => handleClickButton(user)}
                >
                  See Details
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>

      <Modal open={isOpen}>
        <Box style={styleModal}>
          <div>
            <td>
              <h2>Detalles del estudiante</h2>
            </td>
            <td>
              <Button variant="contained" onClick={() => setIsOpen(false)}>
                <h3>x</h3>
              </Button>
            </td>
          </div>

          <table className="table table-table sm">
            <td>
              <h3>Información</h3>
              {selectedStudent && (
                <>
                  <p>
                    <strong> Nombre: </strong>
                    {selectedStudent.name}
                  </p>
                  <p>
                    <strong> Calificación:</strong> {selectedStudent.score}
                  </p>
                  <p>
                    <strong>Estado:</strong> {selectedStudent.status}
                  </p>
                </>
              )}
            </td>
          </table>
        </Box>
      </Modal>
    </div>
  );
};
export default Student;
