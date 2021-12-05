import { Component,OnInit,EventEmitter, Output } from "@angular/core";
import { NgForm } from "@angular/forms";
import{RegisterService}from'./Register.service';
@Component({
  selector:'register-app',
  templateUrl:'./Register.component.html'
})
export class RegisterComponent
{
  /**
   *
   */
  constructor(private Res: RegisterService) {


  }
 
  @Output() cancelRegister=new EventEmitter();
  onSubmit(module:NgForm){
    console.log(module.value)
    this.Res.register(module.value).subscribe(user=>{
     console.log(user)
    },
    error=>{
      console.log(error);
    }
    )
  }
  cancel(){
    this.cancelRegister.emit(false)
  }
}
