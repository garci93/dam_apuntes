import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'courses',
    pathMatch: 'full'
  },
  {
    path: 'courses',
    children: [
      {
        path: '',
        loadChildren: () => import('./main-page/main-page.module').then( m => m.MainPagePageModule)
      },
      {
        path: ':courseId',
        loadChildren: () => import('./main-page/details-page/details-page.module').then( m => m.DetailsPagePageModule)
      }
    ]
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
