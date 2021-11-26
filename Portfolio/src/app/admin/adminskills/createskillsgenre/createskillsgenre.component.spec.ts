import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateskillsgenreComponent } from './createskillsgenre.component';

describe('CreateskillsgenreComponent', () => {
  let component: CreateskillsgenreComponent;
  let fixture: ComponentFixture<CreateskillsgenreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateskillsgenreComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateskillsgenreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
