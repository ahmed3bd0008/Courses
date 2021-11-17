import { MatDialogRef } from "@angular/material/dialog";
import { Component } from "@angular/core";
import { NgForm } from "@angular/forms";
import { counteryService } from "../countery.service";
import { addCountery } from "../countery";

@Component({
  selector:'add-countery-app',
  templateUrl:'./add-countery.component.html'
})
export class addcounterycomponent
{
  /**
   *
   */
  constructor(private counterserv:counteryService, private dailog:MatDialogRef<addcounterycomponent>) {}
  closeDialog(){
    this.dailog.close('addcounterycomponent');
  }
  onSubmit(model:NgForm){
    // this.counterserv.addcountery(model.value as Countery).subscribe(
    //   Response=>{
    //     console.log(Response);
    //   },
    //   error=>{
    //       console.log(error);
    //   }
    // )
  }
}
