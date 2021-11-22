import { Component } from "@angular/core";
import { NgForm } from "@angular/forms";

@Component({
  selector:'add-city-app',
  templateUrl:'./add-city.component.html'
})
export class addcitycomponent{
  constructor(){}
  onSubmit(model:NgForm){
    console.log(model)
  }
  addItem(newItem: string) {
    console.log(newItem);
  }
}
