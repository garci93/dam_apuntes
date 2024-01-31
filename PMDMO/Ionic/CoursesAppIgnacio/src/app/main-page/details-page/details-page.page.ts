import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AlertController } from '@ionic/angular';
import { CoursesService } from 'src/services/courses-service/courses.service';
import { PhotoService } from 'src/services/photo-service/photo.service';

@Component({
  selector: 'app-details-page',
  templateUrl: './details-page.page.html',
  styleUrls: ['./details-page.page.scss'],
})
export class DetailsPagePage implements OnInit {
  course: any;
  actionSheetButtons = [
    {
      text: 'Cámara',
      handler: () => this.pickFromCamera(),
    },
    {
      text: 'Galería',
      handler: () => this.pickFromGallery(),
    },
    {
      text: 'Cancelar',
      role: 'cancel',
      data: {
        action: 'cancel',
      },
    },
  ];

  constructor(
    private activatedRoute: ActivatedRoute,
    private coursesService: CoursesService,
    private router: Router,
    private alertCtrl: AlertController,
    private photoService: PhotoService
    ) { }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(paramMap => {
      if (!paramMap.has('courseId')) {
        this.router.navigate(['/courses']);
        return;
      }
      const id = paramMap.get('courseId');
      
      if (id) {
        this.course = this.coursesService.getCourse(id);
      }
    });
  }

  onDeleteRecipe(): void {
    this.alertCtrl
      .create({
        header: 'Borrar el curso',
        message: '¿Seguro que quiere borrar el curso?',
        buttons: [
          {
            text: 'Cancelar',
            role: 'cancel'
          },
          {
            text: 'Borrar',
            handler: () => {
              this.coursesService.deleteCourse(this.course['id']);
              this.router.navigate(['/courses']);
            }
          }
        ]
      })
      .then(alertEl => {
        alertEl.present();
      });
  }

  async pickFromCamera(): Promise<void> {
    let imageUrl = await this.photoService.takePhoto();
    
    if (imageUrl) {
      this.course.imageUrl = imageUrl;
      this.addCourseImageUrl(this.course['id'], imageUrl);
    }
  }

  async pickFromGallery(): Promise<void> {
    let imageUrl = await this.photoService.pickFromGallery();
    
    if (imageUrl) {
      this.course.imageUrl = imageUrl;
      this.addCourseImageUrl(this.course['id'], imageUrl);
    }
  }

  addCourseImageUrl(id: string, imageUrl: string): void {
    this.coursesService.addCourseImageUrl(id, imageUrl);
  }
}
