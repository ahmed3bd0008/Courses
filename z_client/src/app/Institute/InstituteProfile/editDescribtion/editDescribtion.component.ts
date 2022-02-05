import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { InstituteService } from '../../Institute.service';

@Component({
  selector: 'app-editDescribtion',
  templateUrl: './editDescribtion.component.html',
  styleUrls: ['./editDescribtion.component.css']
})
export class EditDescribtionComponent implements OnInit,OnDestroy {
  describtionstr:string="g";

  constructor(private activeRouter:ActivatedRoute,private router:Router,private instituteService:InstituteService) { }
  ngOnDestroy(): void {

  }

  ngOnInit() {


  }
  close(){
    console.log(this.describtionstr)
    this.instituteService.describeEvent.next(this.describtionstr)
    this.router.routeReuseStrategy.shouldReuseRoute = () => false;
      this.router.onSameUrlNavigation = 'reload';
    this.router.navigate(['../'],{relativeTo:this.activeRouter})

  }
}
