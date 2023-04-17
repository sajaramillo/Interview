import { Component,  OnInit, ViewChild } from '@angular/core';
import { StudentModalComponent } from 'src/app/components/student-modal/student-modal.component';
import { StudentsService } from 'src/app/services/students.service';
import {MatDialog, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { ScorePipe } from 'src/app/pipes/score.pipe';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.scss']
})
export class StudentsComponent implements OnInit {
  studentList =
  [
      {name:'Juan Santamaría', score:9.75, status:'Aprobado'},
      {name:'Carlos Ugarte', score:6.25,  status:'Suspenso'},
      {name:'María Armijos', score:8.50,  status:'Aprobado'},
      {name:'José Baquero', score:5.15,  status:'Reprobado'},
      {name:'Carlos Ordoñez', score:7.75,  status:'Aprobado'},
    ];
    
    data:any = []
    
    constructor(private studentsService:StudentsService,private dialog: MatDialog, private scorePipe:ScorePipe) { }
    
    ngOnInit(): void {
      this.getData();
    }
    
    
    getBackgroundClass(score:number){
      if(score>=7) return 'bg-success';
      else if(score>=5.5 && score<7) return 'bg-warning';
      else return 'bg-danger';
      
    }
    
    async getData(){
      this.data = await this.studentsService.getAll();
      
    }
    
    openModal(student:any) {
      this.dialog.open(StudentModalComponent, {
        data: {
          name: student.name,
          score:student.score,
          status: this.scorePipe.transform(student.score)
        },
      });
  }
}
  