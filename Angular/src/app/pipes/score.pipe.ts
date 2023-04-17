import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'score',
})
export class ScorePipe implements PipeTransform {
  transform(score: number) {
    if (score >= 7) return 'Aprobado';
    else if (score >= 5.5 && score < 7) return 'Suspenso';
    else return 'Reprobado';
  }
}
