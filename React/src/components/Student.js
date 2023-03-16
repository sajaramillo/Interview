import {React} from "react";


export default ()=>{
    const studentList =
    [
        {name:'Juan Santamaría', score:9.75, status:'Aprobado'},
        {name:'Carlos Ugarte', score:6.25,  status:'Suspenso'},
        {name:'María Armijos', score:8.50,  status:'Aprobado'},
        {name:'José Baquero', score:5.15,  status:'Reprobado'},
        {name:'Carlos Ordoñez', score:7.75,  status:'Aprobado'},
    ];

    function getClassNameByStatus(estado){
        switch(estado){
            case 'Aprobado': return 'table-success';
            case 'Reprobado': return 'table-danger';
            case 'Suspenso': return 'table-warning';            
            default: return 'primary'
        }
    }
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
                        studentList.map((student) =>                        
                            <tr className="table-light">
                                <td>{1}</td>
                                <td>{student.name}</td>
                                <td>{student.status}</td>                                
                            </tr>                        
                    )}
                </tbody>
            </table>
        </div>
    );
}