import { Component, OnInit } from "@angular/core";
import { CourseCategory } from "../category";
import{ResponseClient}from"../../../ResponseClient";
import{coursecatagoryservice}from "../../coursecatagory/course-catagory.service";
@Component({
  selector:"selectcoursecategory-app",
  templateUrl:"./select-course-category.component.html"
})
export class selectCourseCategoryComponent implements OnInit
{
        CourseCategories:CourseCategory[]=[];
       constructor(private catagoryService: coursecatagoryservice) {}
       getCourseCatagory(){
         this.catagoryService.getCategory()
           .subscribe(arg=>
             {
                 const categories:ResponseClient=arg;
                 this.CourseCategories=categories.data as CourseCategory[];
             });

       }
       ngOnInit(): void {
         this.getCourseCatagory()
       }
}
