import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-Institute',
  templateUrl: './Institute.component.html',
  styleUrls: ['./Institute.component.css']
})
export class InstituteComponent implements OnInit {

  constructor( private activeRouter:ActivatedRoute,private router:Router) { }

  ngOnInit() {
  }
  
}
