import { ComponentFixture, TestBed } from '@angular/core/testing';
import { DetailsPagePage } from './details-page.page';

describe('DetailsPagePage', () => {
  let component: DetailsPagePage;
  let fixture: ComponentFixture<DetailsPagePage>;

  beforeEach(async(() => {
    fixture = TestBed.createComponent(DetailsPagePage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
