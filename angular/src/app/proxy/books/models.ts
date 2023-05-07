import type { AuditedEntityDto, EntityDto } from '@abp/ng.core';
import type { BookType } from './book-type.enum';
import type { HomeExpensesResource } from '../localization/models';

export interface AuthorLookupDto extends EntityDto<string> {
  name?: string;
}

export interface BookDto extends AuditedEntityDto<string> {
  name?: string;
  type: BookType;
  resources: HomeExpensesResource;
  publishDate?: string;
  price: number;
  authorId?: string;
  authorName?: string;
}

export interface CreateUpdateBookDto {
  name: string;
  type: BookType;
  publishDate: string;
  price: number;
  authorId?: string;
}
