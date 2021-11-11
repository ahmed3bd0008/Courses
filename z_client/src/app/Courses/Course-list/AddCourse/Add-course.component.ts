import { Component } from "@angular/core";
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { SelectCourseComponent } from "../../courseLevel/CourseLevelSelect/select-course/select-course.component";


@Component({
  selector:'add-course-app',
  templateUrl:'./Add-course.component.html',

})

export class AddCourseComponent{
constructor(public dialogRef: MatDialogRef<AddCourseComponent>)
{

}
SlidNumber:number=1;
Privousslid:boolean=false;
Nextslid:boolean=false;
closeDialog() {
  console.log("close");
  this.dialogRef.close('AddCourseComponent!');
}

OnclickSlid(){
if(this.SlidNumber==2)
{
  this.Privousslid=false;
  this.Nextslid=false;
}
else if (this.SlidNumber==1) {
this.Privousslid=true;
} else {
  this.Nextslid=true;
}
}
}
