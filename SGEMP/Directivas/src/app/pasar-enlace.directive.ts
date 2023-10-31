import { Directive, ElementRef, HostBinding, HostListener } from '@angular/core';
import { EnlaceComponent } from './enlace/enlace.component';

@Directive({
  selector: '[appPasarEnlace]'
})
export class PasarEnlaceDirective {
  @HostBinding('class.card-outline-primary')private ishovering: boolean;
  constructor(private el: ElementRef,
  private enlace: EnlaceComponent) {
  // renderer.setElementStyle(el.nativeElement, 'backgroundColor', 'gray');
  }
  @HostListener('mouseover') onMouseOver() {
  let part = this.el.nativeElement.querySelector('.card-text');
  this.enlace.setElementStyle(part, 'display', 'block');
  this.ishovering = true;
  }
  @HostListener('mouseout') onMouseOut() {
  let part = this.el.nativeElement.querySelector('.card-text');
  this.enlace.setElementStyle(part, 'display', 'none');
255
  this.ishovering = false;
  }

}
