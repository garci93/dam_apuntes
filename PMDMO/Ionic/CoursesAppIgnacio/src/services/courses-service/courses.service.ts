import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Course } from 'src/classes/course/course';
import { v4 as uuidv4 } from 'uuid';
import { Filesystem, Directory, Encoding } from '@capacitor/filesystem';

@Injectable({
  providedIn: 'root'
})
export class CoursesService {
  private _courses!: Course[];
  private _subject!: BehaviorSubject<any>;

  constructor() {
    this._subject = new BehaviorSubject([]);
    this.getData();
  }

  async getData(): Promise<void> {
    this._courses = await this.getCourses();
    this.subjectNext();
  }

  getObservable() {
    return this._subject.asObservable();
  }

  getCourse(id: string) {
    let course = this._courses.find(course => course.id === id);

    if (course) {
      return {
        id: course.id,
        title: course.title,
        points: course.points,
        imageUrl: course.imageUrl
      };
    }

    return null;
  }

  addCourse(course: any): void {
    this._courses.push(new Course(uuidv4(), course['title'], course['points']));
    this.subjectNext();
  }

  deleteCourse(id: string): void {
    this._courses = this._courses.filter(course => course.id !== id);
    this.subjectNext();
  }

  addCourseImageUrl(id: string, imageUrl: string): void {
    let course = this._courses.find(course => course.id === id);

    if (course) {
      course.imageUrl = imageUrl;
      this.subjectNext();
    }
  }

  async subjectNext(): Promise<void> {
    await this.saveCourses();

    this._subject.next(this._courses.map(
      (course) => {
        return {
          id: course.id,
          title: course.title,
          points: course.points,
          imageUrl: course.imageUrl
        };
      }
    ));
  }

  async saveCourses(): Promise<void> {
    try {
      await Filesystem.writeFile({
        path: 'courses',
        data: JSON.stringify(this._courses),
        directory: Directory.Data,
        encoding: Encoding.UTF8
      })
    } catch (e) {
      console.error('Unable to write file', e);
    }
  }

  async getCourses(): Promise<any[]> {
    try {
      const contents = await Filesystem.readFile({
        path: 'courses',
        directory: Directory.Data,
        encoding: Encoding.UTF8,
      });

      if (typeof contents.data == 'string') {
        return JSON.parse(contents.data).map((course: any) => new Course(course._id, course._title, course._points, course._imageUrl));
      }
      return [];
    } catch (error) {
      return [];
    }
  }
}