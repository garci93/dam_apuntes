import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { CoursesService } from 'src/services/courses-service/courses.service';

@Component({
  selector: 'main-page',
  templateUrl: './main-page.page.html',
  styleUrls: ['./main-page.page.scss'],
})
export class MainPagePage implements OnInit {
  observable: Observable<any>;

  constructor(private coursesService: CoursesService) { 
    this.observable = coursesService.getObservable();
  }

  ngOnInit() {
  }

  addCourse(course: any): void {
    this.coursesService.addCourse(course);
  }

}
