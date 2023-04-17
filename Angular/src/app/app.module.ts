import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentsComponent } from './pages/students/students.component';
import { ScorePipe } from './pipes/score.pipe';
import { StudentsService } from './services/students.service';
import { StudentModalComponent } from './components/student-modal/student-modal.component';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
  declarations: [
    AppComponent,
    StudentModalComponent,
    StudentsComponent,
    ScorePipe,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    MatDialogModule,
    BrowserAnimationsModule
  ],
  providers: [StudentsService,ScorePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
