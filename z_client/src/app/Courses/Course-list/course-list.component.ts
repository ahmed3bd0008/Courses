import { Component } from "@angular/core";
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { AddCourseComponent } from "./AddCourse/Add-course.component";

@Component({
  selector:'courselist-app',
  templateUrl:'./course-list.component.html'
})
export class courselistcomponent
{
  constructor(public dialog: MatDialog) {}
  openDialog(): void {
    const dialogRef = this.dialog.open(AddCourseComponent, {
      height: '900px',
      width: '1200px',
      disableClose: true
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });

}

}
