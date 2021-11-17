import { MatDialogRef } from "@angular/material/dialog";
import { Component } from "@angular/core";
import { NgForm } from "@angular/forms";
import { counteryService } from "../countery.service";
import { addCountery } from "../countery";
import{ToastrService}from 'ngx-toastr';
@Component({
  selector:'add-countery-app',
  templateUrl:'./add-countery.component.html'
})
export class addcounterycomponent
{
  constructor(private counterserv:counteryService,private toastrS:ToastrService, private dailog:MatDialogRef<addcounterycomponent>) {}
  closeDialog(){
    this.dailog.close('addcounterycomponent');
  }
  onSubmit(model:NgForm){

    const countery:addCountery=model.value as addCountery;
    console.log(countery);
    this.counterserv.addcountery(countery).subscribe(
      Response=>{
        this.toastrS.success("good")
        console.log(Response);
      },
      error=>{
          console.log(error);
          this.toastrS.success("good")
      }
    )
  }
}
