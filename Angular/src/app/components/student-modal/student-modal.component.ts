import {Component, Inject,OnInit} from '@angular/core';
import {MatDialog, MAT_DIALOG_DATA} from '@angular/material/dialog';
@Component({
  selector: 'modal',
  templateUrl: './student-modal.component.html',
  styleUrls: ['./student-modal.component.scss']
})
export class StudentModalComponent implements OnInit {

   constructor(@Inject(MAT_DIALOG_DATA) public data: any){
   }

  ngOnInit() {
  }




}
