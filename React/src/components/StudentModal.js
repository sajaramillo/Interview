import React from 'react';

const StudentModal = ({ student, onClose }) => {
  
  const assignStatus = (score) => {
    if (score >= 7) return 'Aprobado';
    if (score >= 5.5) return 'Suspenso';
    if (score < 5.5) return 'Reprobado';
  };

  return (
    <div className="modal-backdrop">
      <div className="modal-content">
        <div className="modal-header">
          <h5 className="modal-title">Detalles del estudiante</h5>
          <span className="close-button" onClick={onClose}>X</span>
        </div>
        <div className="modal-body">
          <h2 className='information-h2'>Información</h2>
          <p><strong>Nombre:</strong> {student.name}</p>
          <p><strong>Calificación:</strong> {student.score}</p>
          <p><strong>Estado:</strong> {assignStatus(student.score)}</p>
        </div>
      </div>
    </div>
  );
};

export default StudentModal;
