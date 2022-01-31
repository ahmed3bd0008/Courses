import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-editDescribtion',
  templateUrl: './editDescribtion.component.html',
  styleUrls: ['./editDescribtion.component.css']
})
export class EditDescribtionComponent implements OnInit {

  constructor(private activeRouter:ActivatedRoute,private router:Router) { }

  ngOnInit() {
  }
  close(){
    this.router.navigate(['../'],{relativeTo:this.activeRouter})
  }
}
