import React from 'react';

const StudentModal = ({student, closeModal, status}) =>(
  <div className="modal" style={{ display: 'block' }}>
        <div className="modal-dialog">
            <div className="modal-content">
                <div className="modal-header">
                    <h5 className="modal-title">Detalles del estudiante</h5>
                    
                    <button type="button" className="close" onClick={closeModal}>
                        <span>&times;</span>
                    </button>
                </div>
                <div className="modal-body">
                    <h5>Infomación</h5>
                    <p><strong>Nombre del alumno:</strong> {student.name}</p>
                    <p><strong>Calificación:</strong> {student.score}</p>
                    <p><strong>Estado:</strong> {status}</p>
                    
                </div>
                
            </div>
        </div>
    </div>
);
export default StudentModal;