import { MatDialogRef, MAT_DIALOG_DATA } from "@angular/material/dialog";
import { Component, Inject, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { counteryService } from "../countery.service";
import { addCountery, Countery } from "../countery";
import{ToastrService}from 'ngx-toastr';
@Component({
  selector:'add-countery-app',
  templateUrl:'./add-countery.component.html'
})
export class addcounterycomponent implements OnInit
{

  constructor(private counterserv:counteryService,private toastrS:ToastrService,
              private dailog:MatDialogRef<addcounterycomponent>,
              @Inject(MAT_DIALOG_DATA) public Data:Countery) {}
  ngOnInit(): void {

  }
  closeDialog(){
    this.dailog.close('addcounterycomponent');
  }
  onSubmit(model:NgForm){

    const countery:addCountery=model.value as addCountery;
    console.log(countery);
    this.counterserv.addcountery(countery).subscribe(
      Response =>{
        console.log(Response.data);
        console.log('ggdf');
        this.toastrS.error("good")
        this.closeDialog();
      },
      error=>{
          console.log(error);
          this.toastrS.error("good")
      }
    )
  }
}
