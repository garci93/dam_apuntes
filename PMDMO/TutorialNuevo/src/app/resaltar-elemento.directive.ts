import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appResaltarElemento]'
})
export class ResaltarElementoDirective {

  @Input('appResaltarElemento') resaltarColor: string = 'yellow';

  constructor(private el: ElementRef) {}

  @HostListener('mouseenter') onMouseEnter() {
    this.resaltar(this.resaltarColor);
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.el.nativeElement.style.backgroundColor = null;
  }

  private resaltar(color: string) {
    this.el.nativeElement.style.backgroundColor = color;
  }
}
