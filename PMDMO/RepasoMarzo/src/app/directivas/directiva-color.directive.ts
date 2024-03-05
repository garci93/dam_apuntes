import { Directive, ElementRef, Host, HostListener, Input, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appDirectivaColor]'
})
export class DirectivaColorDirective {

  @Input('textoColor') color: any = {color: 'blue'};

  constructor(private el: ElementRef, private renderer: Renderer2) { }

  @HostListener('mouseenter') ratonEncima() {
    this.renderer.setStyle(this.el.nativeElement, 'color', `${this.color.color}`);
  }

  @HostListener('mouseleave') ratonFuera() {
    this.renderer.removeStyle(this.el.nativeElement, 'color');
  }

}
