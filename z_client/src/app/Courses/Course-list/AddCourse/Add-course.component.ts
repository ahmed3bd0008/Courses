import { Component } from "@angular/core";
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
@Component({
  selector:'add-course-app',
  templateUrl:'./Add-course.component.html',

})
export class AddCourseComponent{
constructor(public dialogRef: MatDialogRef<AddCourseComponent>)
{

}
closeDialog() {
  console.log("close");
  this.dialogRef.close('AddCourseComponent!');
}
}
