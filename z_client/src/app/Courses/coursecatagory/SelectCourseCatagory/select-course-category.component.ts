import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { CourseCategory } from "../category";
@Component({
  selector:"selectcoursecategory-app",
  templateUrl:"./select-course-category.component.html"
})
export class selectCourseCategoryComponent implements OnInit
{
    /**
     *
     */
    courseCategories :CourseCategory[]=[];
    constructor(client:HttpClient) {

    }
    getAllCategory(){
      
    }
  ngOnInit(): void {
    throw new Error("Method not implemented.");
  }
}
