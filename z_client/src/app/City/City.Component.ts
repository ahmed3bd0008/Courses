import { Component } from "@angular/core";
@Component({
  selector:'city-app',
  templateUrl:'./City.Component.html'
})
export class CityComponent{
  addItem(newItem: string) {
    console.log(newItem)
  }
}
