import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DetailsPagePage } from './details-page.page';

const routes: Routes = [
  {
    path: '',
    component: DetailsPagePage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DetailsPagePageRoutingModule {}
