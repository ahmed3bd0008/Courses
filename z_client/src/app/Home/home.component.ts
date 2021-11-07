import { Component,OnInit } from "@angular/core";
@Component({
  selector:'home-app',
  templateUrl:'./home.component.html'
})
export class homecomponent implements OnInit
{
  ngOnInit(): void {
    this.register=false;
  }
  register:boolean=false;
  registerToggle()
  {
    this.register=!this.register;
  }
  cancellRegistModl(event :boolean)
  {
    this.register=event;
  }

}
