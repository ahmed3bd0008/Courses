import { Component, Input } from "@angular/core";
import{cityCountery}from "../city"
@Component({
  selector:'update-city-app',
  templateUrl:'./update-city.component.html'
})
export class updateCityComponent{
 @Input()updateCity !:cityCountery;
 
}
