import { AfterViewInit, Component, ElementRef, Input, ViewChild } from '@angular/core';

@Component({
  selector: 'app-cabecera-codigo',
  templateUrl: './cabecera3.component.html',
  styleUrls: ['./cabecera3.component.css']
})
export class Cabecera3Component implements AfterViewInit {
  @ViewChild('logo') cabecera!: ElementRef;
  ngAfterViewInit(): void {
    this.cabecera!.nativeElement.src="../assets/logoPers.png";
  }
}
